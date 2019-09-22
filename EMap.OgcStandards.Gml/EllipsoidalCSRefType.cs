namespace EMap.OgcStandards.Gml {
    
    
    /// <remarks/>
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("ellipsoidalCSRef", Namespace="http://www.opengis.net/gml", IsNullable=false)]
    public partial class EllipsoidalCSRefType {
        
        private EllipsoidalCSType ellipsoidalCSField;
        
        private string remoteSchemaField;
        
        /// <remarks/>
        public EllipsoidalCSType EllipsoidalCS {
            get {
                return this.ellipsoidalCSField;
            }
            set {
                this.ellipsoidalCSField = value;
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
