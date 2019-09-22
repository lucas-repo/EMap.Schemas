namespace EMap.OgcStandards.Gml {
    
    
    /// <remarks/>
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("parameterValue", Namespace="http://www.opengis.net/gml", IsNullable=false)]
    public partial class AbstractGeneralParameterValuePropertyType {
        
        private AbstractGeneralParameterValueType abstractGeneralParameterValueField;
        
        /// <remarks/>
        public AbstractGeneralParameterValueType AbstractGeneralParameterValue {
            get {
                return this.abstractGeneralParameterValueField;
            }
            set {
                this.abstractGeneralParameterValueField = value;
            }
        }
    }
}
