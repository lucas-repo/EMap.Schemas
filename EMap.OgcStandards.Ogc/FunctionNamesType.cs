namespace EMap.OgcStandards.Ogc {
    
    
    /// <remarks/>
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/ogc")]
    public partial class FunctionNamesType {
        
        private FunctionNameType[] functionNameField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("FunctionName")]
        public FunctionNameType[] FunctionName {
            get {
                return this.functionNameField;
            }
            set {
                this.functionNameField = value;
            }
        }
    }
}
