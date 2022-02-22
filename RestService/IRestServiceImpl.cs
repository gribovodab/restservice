using System.ComponentModel;
using System.Net.Http;
using System.ServiceModel;
using System.ServiceModel.Web;

namespace RestService
{

    [ServiceContract]
    public interface IRestServiceImpl
    {
        [OperationContract]
        [WebInvoke(Method = "GET",
            ResponseFormat = WebMessageFormat.Xml,
            BodyStyle = WebMessageBodyStyle.Wrapped,
            UriTemplate = "xml/{id}")]
        string XMLData(string id);

        [OperationContract]
        [WebInvoke(Method = "GET",
            ResponseFormat = WebMessageFormat.Json,
            BodyStyle = WebMessageBodyStyle.Wrapped,
            UriTemplate = "json/{id}")]
        string JSONData(string id);
    }

    public class ChangeProduct : INotifyPropertyChanged
    {
        private string infoProductChange;
        protected void OnPropertyChanged(PropertyChangedEventArgs e)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
                handler(this, e);
        }
        protected void OnPropertyChanged(string propertyName)
        {
            OnPropertyChanged(new PropertyChangedEventArgs(propertyName));
        }
        public string InfoProductChange
        {
            get { return infoProductChange; }
            set
            {
                if (value != infoProductChange)
                {
                    infoProductChange = value;
                    OnPropertyChanged("InfoProductChange");
                }
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;
    }

    public class ChangeSale : INotifyPropertyChanged
    {
        private string infoSaleChange;
        protected void OnPropertyChanged(PropertyChangedEventArgs e)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
                handler(this, e);
        }
        protected void OnPropertyChanged(string propertyName)
        {
            OnPropertyChanged(new PropertyChangedEventArgs(propertyName));
        }
        public string InfoSaleChange
        {
            get { return infoSaleChange; }
            set
            {
                if (value != infoSaleChange)
                {
                    infoSaleChange = value;
                    OnPropertyChanged("InfoSaleChange");
                }
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;
    }


}
