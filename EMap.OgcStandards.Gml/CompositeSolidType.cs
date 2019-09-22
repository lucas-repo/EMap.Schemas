namespace EMap.OgcStandards.Gml {
    
    
    /// <remarks/>
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("CompositeSolid", Namespace="http://www.opengis.net/gml", IsNullable=false)]
    public partial class CompositeSolidType : AbstractSolidType {
        
        private SolidPropertyType[] solidMemberField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("solidMember")]
        public SolidPropertyType[] solidMember {
            get {
                return this.solidMemberField;
            }
            set {
                this.solidMemberField = value;
            }
        }
    }
}
