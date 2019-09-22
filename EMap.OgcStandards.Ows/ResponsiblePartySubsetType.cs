namespace EMap.OgcStandards.Ows {
    
    
    /// <remarks/>
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/ows")]
    public partial class ResponsiblePartySubsetType {
        
        private string individualNameField;
        
        private string positionNameField;
        
        private ContactType contactInfoField;
        
        private CodeType1 roleField;
        
        /// <remarks/>
        public string IndividualName {
            get {
                return this.individualNameField;
            }
            set {
                this.individualNameField = value;
            }
        }
        
        /// <remarks/>
        public string PositionName {
            get {
                return this.positionNameField;
            }
            set {
                this.positionNameField = value;
            }
        }
        
        /// <remarks/>
        public ContactType ContactInfo {
            get {
                return this.contactInfoField;
            }
            set {
                this.contactInfoField = value;
            }
        }
        
        /// <remarks/>
        public CodeType1 Role {
            get {
                return this.roleField;
            }
            set {
                this.roleField = value;
            }
        }
    }
}
