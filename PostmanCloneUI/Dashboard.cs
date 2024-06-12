namespace PostmanCloneUI
{
	public partial class Dashboard : Form
	{
		public Dashboard()
		{
			InitializeComponent();
		}

		private void listView1_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{

		}

		private void label2_Click(object sender, EventArgs e)
		{

		}

		private async void callApi_Click(object sender, EventArgs e)
		{
			// Validate API URL

			try
			{
				systemStatus.Text = "Calling API..";

				// Sample code - replace with the actual API call
				await Task.Delay(2000);

				systemStatus.Text = "Ready";
			}
			catch (Exception ex)
			{
				resultsBox.Text = "Error: " + ex.Message;
				systemStatus.Text = "Error";
			}

		}

		private void resultsLabel_Click(object sender, EventArgs e)
		{

		}
	}
}