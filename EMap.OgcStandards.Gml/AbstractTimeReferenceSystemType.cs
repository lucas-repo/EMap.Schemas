namespace EMap.OgcStandards.Gml {
    
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TimeClockType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TimeCalendarType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TimeOrdinalReferenceSystemType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TimeCoordinateSystemType))]
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml")]
    public abstract partial class AbstractTimeReferenceSystemType : DefinitionType {
        
        private string domainOfValidityField;
        
        /// <remarks/>
        public string domainOfValidity {
            get {
                return this.domainOfValidityField;
            }
            set {
                this.domainOfValidityField = value;
            }
        }
    }
}
