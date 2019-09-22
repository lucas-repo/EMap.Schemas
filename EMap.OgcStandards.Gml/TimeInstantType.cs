namespace EMap.OgcStandards.Gml {
    
    
    /// <remarks/>
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("TimeInstant", Namespace="http://www.opengis.net/gml", IsNullable=false)]
    public partial class TimeInstantType : AbstractTimeGeometricPrimitiveType {
        
        private TimePositionType timePositionField;
        
        /// <remarks/>
        public TimePositionType timePosition {
            get {
                return this.timePositionField;
            }
            set {
                this.timePositionField = value;
            }
        }
    }
}
