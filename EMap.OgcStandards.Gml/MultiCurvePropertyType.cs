namespace EMap.OgcStandards.Gml {
    
    
    /// <remarks/>
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("multiCurveProperty", Namespace="http://www.opengis.net/gml", IsNullable=false)]
    public partial class MultiCurvePropertyType {
        
        private MultiCurveType multiCurveField;
        
        private string remoteSchemaField;
        
        /// <remarks/>
        public MultiCurveType MultiCurve {
            get {
                return this.multiCurveField;
            }
            set {
                this.multiCurveField = value;
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
