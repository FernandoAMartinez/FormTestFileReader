using System;
using System.Runtime.Serialization;
using System.Xml.Serialization;
using System.Collections.Generic;

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
        #region SerializationStrategy
        //Inicio Modificación - FernandoAMartinez - 31/03/2020
        private ISerializationStrategy strategy;

        public void SetStrategy(ISerializationStrategy strategy) =>
            this.strategy = strategy;

        public void ExecuteSerialization(string filepath, List<FormatFileGenerator.Format> formats) =>
            strategy.SerializeFile(filepath, formats);

        public List<FormatFileGenerator.Format> ExecuteDeserialization(string filepath) =>
            strategy.DeserializeFile(filepath);
        //Fin Modificación - FernandoAMartinez - 31/03/2020
        #endregion

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

        [XmlElement]
        public bool BackgroundSerialization { get; set; }

        [XmlElement]
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
