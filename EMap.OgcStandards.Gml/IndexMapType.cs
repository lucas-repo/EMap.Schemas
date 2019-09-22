namespace EMap.OgcStandards.Gml {
    
    
    /// <remarks/>
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("IndexMap", Namespace="http://www.opengis.net/gml", IsNullable=false)]
    public partial class IndexMapType : GridFunctionType {
        
        private string lookUpTableField;
        
        /// <remarks/>
        public string lookUpTable {
            get {
                return this.lookUpTableField;
            }
            set {
                this.lookUpTableField = value;
            }
        }
    }
}
