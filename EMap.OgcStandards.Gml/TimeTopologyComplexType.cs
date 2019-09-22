namespace EMap.OgcStandards.Gml {
    
    
    /// <remarks/>
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("TimeTopologyComplex", Namespace="http://www.opengis.net/gml", IsNullable=false)]
    public partial class TimeTopologyComplexType : AbstractTimeComplexType {
        
        private TimeTopologyPrimitivePropertyType[] primitiveField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("primitive")]
        public TimeTopologyPrimitivePropertyType[] primitive {
            get {
                return this.primitiveField;
            }
            set {
                this.primitiveField = value;
            }
        }
    }
}
