namespace EMap.OgcStandards.Gml {
    
    
    /// <remarks/>
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("MultiSolid", Namespace="http://www.opengis.net/gml", IsNullable=false)]
    public partial class MultiSolidType : AbstractGeometricAggregateType {
        
        private SolidPropertyType[] solidMemberField;
        
        private SolidArrayPropertyType solidMembersField;
        
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
        
        /// <remarks/>
        public SolidArrayPropertyType solidMembers {
            get {
                return this.solidMembersField;
            }
            set {
                this.solidMembersField = value;
            }
        }
    }
}
