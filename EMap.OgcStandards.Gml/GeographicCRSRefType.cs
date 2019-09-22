namespace EMap.OgcStandards.Gml {
    
    
    /// <remarks/>
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("geographicCRSRef", Namespace="http://www.opengis.net/gml", IsNullable=false)]
    public partial class GeographicCRSRefType {
        
        private GeographicCRSType geographicCRSField;
        
        private string remoteSchemaField;
        
        /// <remarks/>
        public GeographicCRSType GeographicCRS {
            get {
                return this.geographicCRSField;
            }
            set {
                this.geographicCRSField = value;
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
