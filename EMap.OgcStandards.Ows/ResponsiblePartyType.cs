namespace EMap.OgcStandards.Ows {
    
    
    /// <remarks/>
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/ows")]
    [System.Xml.Serialization.XmlRootAttribute("PointOfContact", Namespace="http://www.opengis.net/ows", IsNullable=false)]
    public partial class ResponsiblePartyType {
        
        private string individualNameField;
        
        private string organisationNameField;
        
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
        public string OrganisationName {
            get {
                return this.organisationNameField;
            }
            set {
                this.organisationNameField = value;
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
