namespace EMap.OgcStandards.Gml {
    
    
    /// <remarks/>
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("MultiLineString", Namespace="http://www.opengis.net/gml", IsNullable=false)]
    public partial class MultiLineStringType : AbstractGeometricAggregateType {
        
        private LineStringPropertyType[] lineStringMemberField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("lineStringMember")]
        public LineStringPropertyType[] lineStringMember {
            get {
                return this.lineStringMemberField;
            }
            set {
                this.lineStringMemberField = value;
            }
        }
    }
}
