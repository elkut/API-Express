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
                switch (requestBox.Text)
                {
                    case "GET":
                        resultsBox.Text = await api.CallApiAsync(urlBox.Text);
                        break;
                    case "POST":
                        resultsBox.Text = await api.CallApiAsync(urlBox.Text, HttpAction.POST, bodyBox.Text);
                        break;
                    case "PUT":
                        resultsBox.Text = await api.CallApiAsync(urlBox.Text, HttpAction.PUT, bodyBox.Text);
                        break;
                    case "PATCH":
                        resultsBox.Text = await api.CallApiAsync(urlBox.Text, HttpAction.PATCH, bodyBox.Text);
                        break;
                    case "DELETE":
                        resultsBox.Text = await api.CallApiAsync(urlBox.Text);
                        break;
                    default:
                        resultsBox.Text = "";
                        break;
                }

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