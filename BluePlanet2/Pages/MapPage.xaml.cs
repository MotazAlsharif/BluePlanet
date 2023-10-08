using Microsoft.Maui.Controls;

using System;
using System.Threading.Tasks;

namespace BluePlanet2.Pages
{
    public partial class MapPage : ContentPage
    {
        public MapPage()
        {
            InitializeComponent();

            // Hook up the WebView Navigated event to handle map clicks
            mapWebView.Navigated += OnWebViewNavigated;

            // Fetch the current location, temperature, and weather warnings when the page loads
            GetCurrentLocationTemperatureAndWarningsAsync();
        }

        private async Task<double> GetTemperatureForLocationAsync(double latitude, double longitude)
        {
            // Implement the logic to fetch temperature data based on coordinates here.
            // You may use an external weather API or service that provides temperature data.

            // For this example, we return a dummy temperature value.
            // In a real application, replace this with your data retrieval code.
            await Task.Delay(1000); // Simulate a delay (e.g., an API request)

            // Replace this with the actual temperature retrieval logic from your API response
            // Here, we return a fixed value for demonstration purposes.
            return 25.5; // Dummy temperature value
        }

        private async void OnWebViewNavigated(object sender, WebNavigatedEventArgs e)
        {
            // This event is fired when the WebView finishes loading a new page.
            // You can handle the map click event here and retrieve temperature data.
            // For demonstration, we'll use a dummy temperature value.

            // Example: Simulate fetching temperature data for a clicked location
            double clickedTemperature = await GetTemperatureForLocationAsync(42.3601, -71.0589); // Coordinates for Boston, MA

            // Update the temperature display frame
            temperatureFrame.IsVisible = true;
            temperatureFrame.BackgroundColor = GetTemperatureColor(clickedTemperature);
            temperatureLabel.Text = $"Temperature: {clickedTemperature} °C";

            // Update the weather warnings display frame
            warningsFrame.IsVisible = true; // Show the weather warnings frame
            warningsFrame.BackgroundColor = GetWarningsColor(); // Set background color based on your logic
            warningsLabel.Text = "Weather Warnings: No Warnings" ; // Set the text based on your logic

         

        }

        private async void GetCurrentLocationTemperatureAndWarningsAsync()
        {
            try
            {
                // Get the current device location
                var location = await Geolocation.GetLocationAsync();

                if (location != null)
                {
                    // Call a weather API to get the current temperature and weather warnings based on the location
                    (double currentTemperature, string weatherWarnings) = await GetDataForLocationAsync(location.Latitude, location.Longitude);

                    // Update the temperature display frame with the current temperature
                    temperatureFrame.IsVisible = true;
                    temperatureFrame.BackgroundColor = GetTemperatureColor(currentTemperature);
                    temperatureLabel.Text = $"Temperature: {currentTemperature} °C";

                    // Update the weather warnings display frame
                    warningsFrame.IsVisible = !string.IsNullOrWhiteSpace(weatherWarnings);
                    warningsFrame.BackgroundColor = GetWarningsColor(); // Set background color based on your logic
                    warningsLabel.Text = weatherWarnings; // Set the text based on your logic
                }
                else
                {
                    // Handle the case where location couldn't be obtained
                    temperatureLabel.Text = "Location not available";
                }
            }
            catch (Exception ex)
            {
                // Handle exceptions (e.g., permissions denied, no internet connection)
                temperatureLabel.Text = $"Error: {ex.Message}";
            }
        }

        private async Task<(double, string)> GetDataForLocationAsync(double latitude, double longitude)
        {
            // Implement the logic to fetch temperature and weather warnings data based on coordinates here.
            // You may use an external weather API or service that provides this data.

            // For this example, we return dummy values.
            await Task.Delay(1000); // Simulate a delay (e.g., an API request)

            // Replace these with actual data retrieval logic from your API response
            double temperature = 26; // Dummy temperature value
            string warnings = "Severe weather warning: Heavy rain"; // Dummy weather warnings

            return (temperature, warnings);
        }

        private Microsoft.Maui.Graphics.Color GetTemperatureColor(double temperature)
        {
            if (temperature > 30)
                return Microsoft.Maui.Graphics.Color.FromRgb(255, 0, 0); // Red
            else if (temperature > 20)
                return Microsoft.Maui.Graphics.Color.FromRgb(249, 177, 6); // Yellow
            else
                return Microsoft.Maui.Graphics.Color.FromRgb(0, 0, 255); // Blue
        }

        private Microsoft.Maui.Graphics.Color GetWarningsColor()
        {
            // Define the orange color using RGB values
            var orangeColor = new Microsoft.Maui.Graphics.Color(249, 177, 6);

            // Return the defined orange color
            return orangeColor;
        }
    }
}
