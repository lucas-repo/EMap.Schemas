namespace EMap.OgcStandards.Gml {
    
    
    /// <remarks/>
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("verticalCSRef", Namespace="http://www.opengis.net/gml", IsNullable=false)]
    public partial class VerticalCSRefType {
        
        private VerticalCSType verticalCSField;
        
        private string remoteSchemaField;
        
        /// <remarks/>
        public VerticalCSType VerticalCS {
            get {
                return this.verticalCSField;
            }
            set {
                this.verticalCSField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form=System.Xml.Schema.XmlSchemaForm.Qualified, DataType="anyURI")]
        public string remoteSchema {
            get {
                return this.remoteSchemaField;
            }
            set {
                this.remoteSchemaField = value;
            }
        }
    }
}
