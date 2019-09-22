namespace EMap.OgcStandards.Ogc {
    
    
    /// <remarks/>
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/ogc")]
    public partial class FunctionsType {
        
        private FunctionNamesType functionNamesField;
        
        /// <remarks/>
        public FunctionNamesType FunctionNames {
            get {
                return this.functionNamesField;
            }
            set {
                this.functionNamesField = value;
            }
        }
    }
}
