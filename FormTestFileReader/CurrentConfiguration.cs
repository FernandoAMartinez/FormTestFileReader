using System;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace FormTestFileReader
{
    [Serializable, XmlRoot]
    public class CurrentConfiguration
    {


        private static CurrentConfiguration _instance;

        public static CurrentConfiguration Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new CurrentConfiguration();
                return _instance;
            }
        }
        //Current Settings for the form

        #region UserInformation
        [XmlAttribute]
        public string CurrentUser { get; set; }

        [XmlElement]
        public string FilesDirectory { get; set; }
        
        [XmlElement]
        public DateTime LastAction { get; set; }
        #endregion


        #region Serialization
        [XmlElement]
        public bool SerializeFiles { get; set; }

        [XmlAttribute]
        public string SerializationType { get; set; }
        #endregion

        #region Formats

        #endregion

        #region Methods
        public void UpdateWithAction() => LastAction = DateTime.Now;

        public void LoadPreferences(CurrentConfiguration configuration) => _instance = configuration;
        
        #endregion
    }
}
