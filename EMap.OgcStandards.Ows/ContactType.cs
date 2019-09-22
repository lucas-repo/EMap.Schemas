namespace EMap.OgcStandards.Ows {
    
    
    /// <remarks/>
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/ows")]
    [System.Xml.Serialization.XmlRootAttribute("ContactInfo", Namespace="http://www.opengis.net/ows", IsNullable=false)]
    public partial class ContactType {
        
        private TelephoneType phoneField;
        
        private AddressType addressField;
        
        private OnlineResourceType1 onlineResourceField;
        
        private string hoursOfServiceField;
        
        private string contactInstructionsField;
        
        /// <remarks/>
        public TelephoneType Phone {
            get {
                return this.phoneField;
            }
            set {
                this.phoneField = value;
            }
        }
        
        /// <remarks/>
        public AddressType Address {
            get {
                return this.addressField;
            }
            set {
                this.addressField = value;
            }
        }
        
        /// <remarks/>
        public OnlineResourceType1 OnlineResource {
            get {
                return this.onlineResourceField;
            }
            set {
                this.onlineResourceField = value;
            }
        }
        
        /// <remarks/>
        public string HoursOfService {
            get {
                return this.hoursOfServiceField;
            }
            set {
                this.hoursOfServiceField = value;
            }
        }
        
        /// <remarks/>
        public string ContactInstructions {
            get {
                return this.contactInstructionsField;
            }
            set {
                this.contactInstructionsField = value;
            }
        }
    }
}
