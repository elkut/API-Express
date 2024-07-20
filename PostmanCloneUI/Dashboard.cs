using PostmanCloneLibrary;

namespace PostmanCloneUI
{
	public partial class Dashboard : Form
	{
		private readonly IApiAccess api = new ApiAccess();		// API

        public Dashboard()
		{
			InitializeComponent();
		}


		private async void CallApi_Click(object sender, EventArgs e)
		{
            systemStatus.Text = "Calling API..";
			// Empty the result text box
            resultsBox.Text = "";

            // Validate API URL
            if (api.IsValidUrl(urlBox.Text) == false)
			{
				systemStatus.Text = "Invalid URL";
				return;
            }

			try
			{
				//systemStatus.Text = "Calling API..";

				// Sample code - replace with the actual API call
				//await Task.Delay(1000);
				//resultsBox.Text = await Class1.GetResultAsync(urlBox.Text);

				resultsBox.Text = await api.CallApiAsync(urlBox.Text);

				systemStatus.Text = "Ready";
			}
			catch (Exception ex)
			{
				resultsBox.Text = "Error: " + ex.Message;
				systemStatus.Text = "Error";
			}

		}

		private void UrlBox_TextChanged(object sender, EventArgs e)
		{
			if (urlBox.Text != "")
			{
				callAPi.Enabled = true;
			}
			else
			{
				callAPi.Enabled = false;
			}
		}
	}
}