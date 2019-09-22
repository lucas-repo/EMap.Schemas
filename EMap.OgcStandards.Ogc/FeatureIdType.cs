namespace EMap.OgcStandards.Ogc {
    
    
    /// <remarks/>
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/ogc")]
    [System.Xml.Serialization.XmlRootAttribute("FeatureId", Namespace="http://www.opengis.net/ogc", IsNullable=false)]
    public partial class FeatureIdType : AbstractIdType {
        
        private string fidField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="ID")]
        public string fid {
            get {
                return this.fidField;
            }
            set {
                this.fidField = value;
            }
        }
    }
}
