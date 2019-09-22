namespace EMap.OgcStandards.Se
{
    
    
    /// <remarks/>
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/se")]
    [System.Xml.Serialization.XmlRootAttribute("AnchorPoint", Namespace="http://www.opengis.net/se", IsNullable=false)]
    public partial class AnchorPointType {
        
        private ParameterValueType anchorPointXField;
        
        private ParameterValueType anchorPointYField;
        
        /// <remarks/>
        public ParameterValueType AnchorPointX {
            get {
                return this.anchorPointXField;
            }
            set {
                this.anchorPointXField = value;
            }
        }
        
        /// <remarks/>
        public ParameterValueType AnchorPointY {
            get {
                return this.anchorPointYField;
            }
            set {
                this.anchorPointYField = value;
            }
        }
    }
}
