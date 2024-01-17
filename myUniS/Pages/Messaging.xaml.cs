using Microsoft.Maui.Controls;
using Microsoft.Maui.Graphics;
using System.Collections.ObjectModel;

namespace myUniS
{
    public partial class Messaging : ContentPage
    {
        private ObservableCollection<Message> messages;

        public Messaging()
        {
            InitializeComponent();

            messages = new ObservableCollection<Message>();
            chatListView.ItemsSource = messages;
        }

        private bool isFirstMessageSent = false;
        private bool isSecondMessageSent = false;

        private void OnSendMessageClicked(object sender, EventArgs e)
        {
            string messageText = messageEntry.Text;
            if (!string.IsNullOrWhiteSpace(messageText))
            {
                
                Message userMessage = new Message
                {
                    Text = messageText,
                    BackgroundColor = Colors.LightBlue,
                    MessageAlignment = LayoutOptions.End
                };

                messages.Add(userMessage);

                
                if (!isFirstMessageSent)
                {
                    Message responseMessage = new Message
                    {
                        Text = "yw gawan nyo backend",
                        BackgroundColor = Colors.LightGreen,
                        MessageAlignment = LayoutOptions.Start
                    };

                    messages.Add(responseMessage);

                    
                    isFirstMessageSent = true;
                }
                else
                {
                    
                    if (!isSecondMessageSent)
                    {
                        Message anotherResponse = new Message
                        {
                            Text = "kahit login authorization lang",
                            BackgroundColor = Colors.LightGreen,
                            MessageAlignment = LayoutOptions.Start
                        };

                        messages.Add(anotherResponse);

                       
                        isSecondMessageSent = true;
                    }
                    else
                    {
                
                        Message thirdResponse = new Message
                        {
                            Text = "INC talaga tayo nito",
                            BackgroundColor = Colors.LightGreen,
                            MessageAlignment = LayoutOptions.Start
                        };

                        messages.Add(thirdResponse);
                    }
                }

             
                messageEntry.Text = string.Empty;
            }
        }

    }

    public class Message
    {
        public string? Text { get; set; }
        public Color BackgroundColor { get; set; } = Colors.Aquamarine; 
        public LayoutOptions MessageAlignment { get; set; } = LayoutOptions.Start; 
    }
}
