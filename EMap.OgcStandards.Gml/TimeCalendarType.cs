namespace EMap.OgcStandards.Gml {
    
    
    /// <remarks/>
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("TimeCalendar", Namespace="http://www.opengis.net/gml", IsNullable=false)]
    public partial class TimeCalendarType : AbstractTimeReferenceSystemType {
        
        private TimeCalendarEraPropertyType[] referenceFrameField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("referenceFrame")]
        public TimeCalendarEraPropertyType[] referenceFrame {
            get {
                return this.referenceFrameField;
            }
            set {
                this.referenceFrameField = value;
            }
        }
    }
}
