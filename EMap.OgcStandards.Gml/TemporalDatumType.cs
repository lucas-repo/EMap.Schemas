namespace EMap.OgcStandards.Gml {
    
    
    /// <remarks/>
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("TemporalDatum", Namespace="http://www.opengis.net/gml", IsNullable=false)]
    public partial class TemporalDatumType : TemporalDatumBaseType {
        
        private System.DateTime originField;
        
        /// <remarks/>
        public System.DateTime origin {
            get {
                return this.originField;
            }
            set {
                this.originField = value;
            }
        }
    }
}
