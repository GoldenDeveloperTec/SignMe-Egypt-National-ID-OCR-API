using System.Diagnostics;

namespace SignMeSample;

public sealed partial class MainForm : Form
{
    public MainForm()
    {
        InitializeComponent();
    }

    // ── Event handlers ───────────────────────────────────────────────────────

    private void BtnBrowse_Click(object? sender, EventArgs e)
    {
        using var dlg = new OpenFileDialog
        {
            Title = "Select National ID Image",
            Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp|All Files|*.*"
        };
        if (dlg.ShowDialog() == DialogResult.OK)
            txtImage.Text = dlg.FileName;
    }

    private async void BtnScan_Click(object? sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(txtApiKey.Text))
        {
            MessageBox.Show(
                "Please enter your API key.\n\n" +
                "You can register for a free key at:\nhttps://api.signme.it",
                "API Key Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            txtApiKey.Focus();
            return;
        }

        if (string.IsNullOrWhiteSpace(txtImage.Text) || !File.Exists(txtImage.Text))
        {
            MessageBox.Show("Please select a valid image file.",
                "Image Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        SetBusy(true);
        ClearResults();

        try
        {
            using var client = new SignMeClient(txtApiKey.Text.Trim());

            SetStatus("Uploading image…");
            var upload = await client.UploadImageAsync(txtImage.Text, cmbIdType.SelectedIndex);

            if (upload.Code != 200 || string.IsNullOrEmpty(upload.Id))
                throw new InvalidOperationException($"Upload failed: {upload.Message}");

            var progress = new Progress<string>(msg => SetStatus(msg));
            SetStatus($"Processing (Job ID: {upload.Id})…");

            var data = await client.PollForResultAsync(upload.Id, progress: progress);

            DisplayResults(data);
            SetStatus("Done! ID scanned successfully.");
        }
        catch (TimeoutException)
        {
            SetStatus("Timed out – the server took too long. Please try again.");
            MessageBox.Show(
                "The server did not return a result within 15 seconds.\nPlease try again.",
                "Timeout", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        catch (InvalidOperationException ex) when (ex.Message.Contains("403"))
        {
            SetStatus("Error: API key rejected (403).");
            var answer = MessageBox.Show(
                "The API key was rejected by the server (403 Forbidden).\n\n" +
                "Things to check:\n" +
                "  • Make sure you copied the full key with no extra spaces\n" +
                "  • The key must be activated on your account\n\n" +
                "Open your API Keys page to verify your key?",
                "API Key Rejected",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (answer == DialogResult.Yes)
                Process.Start(new ProcessStartInfo("https://api.signme.it/api-keys") { UseShellExecute = true });
        }
        catch (Exception ex)
        {
            SetStatus($"Error: {ex.Message}");
            MessageBox.Show($"An error occurred:\n\n{ex.Message}",
                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        finally
        {
            SetBusy(false);
        }
    }

    private void LnkRegister_Click(object? sender, EventArgs e) =>
        Process.Start(new ProcessStartInfo("https://api.signme.it") { UseShellExecute = true });

    private void LnkSupport_Click(object? sender, EventArgs e) =>
        Process.Start(new ProcessStartInfo("https://api.signme.it/support") { UseShellExecute = true });

    // ── Helpers ──────────────────────────────────────────────────────────────

    private void SetBusy(bool busy)
    {
        btnScan.Enabled = !busy;
        btnBrowse.Enabled = !busy;
        txtApiKey.Enabled = !busy;
        cmbIdType.Enabled = !busy;
        btnScan.Text = busy ? "Scanning…" : "Scan ID";
        Cursor = busy ? Cursors.WaitCursor : Cursors.Default;
    }

    private void SetStatus(string message)
    {
        if (InvokeRequired) { Invoke(() => SetStatus(message)); return; }
        lblStatus.Text = message;
        lblStatus.Refresh();
    }

    private void ClearResults()
    {
        foreach (var lbl in new[]
        {
            valFirstName, valLastName,  valNationalId, valBirthday,
            valGender,    valCity,      valAddress,    valReligion,
            valJob,       valIssueDate, valExpiry
        })
            lbl.Text = "—";
    }

    private void DisplayResults(IdData d)
    {
        valFirstName.Text = d.Firstname.Trim();
        valLastName.Text = d.Lastname.Trim();
        valNationalId.Text = d.NationalId;
        valBirthday.Text = d.Birthday;
        valGender.Text = d.Gender;
        valCity.Text = d.City;
        valAddress.Text = (d.Address1 + " " + d.Address2).Trim();
        valReligion.Text = OrDash(d.Religion);
        valJob.Text = OrDash(d.Job);
        valIssueDate.Text = OrDash(d.IssueDate);
        valExpiry.Text = OrDash(d.Expiry);
    }

    private static string OrDash(string? value) =>
        string.IsNullOrWhiteSpace(value) ? "—" : value;

    private void MainForm_Load(object sender, EventArgs e)
    {
        cmbIdType.SelectedIndex = 0;
    }
}
