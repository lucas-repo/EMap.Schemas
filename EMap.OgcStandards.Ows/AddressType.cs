namespace EMap.OgcStandards.Ows
{
    
    
    /// <remarks/>
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/ows")]
    public partial class AddressType {
        
        private string[] deliveryPointField;
        
        private string cityField;
        
        private string administrativeAreaField;
        
        private string postalCodeField;
        
        private string countryField;
        
        private string[] electronicMailAddressField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("DeliveryPoint")]
        public string[] DeliveryPoint {
            get {
                return this.deliveryPointField;
            }
            set {
                this.deliveryPointField = value;
            }
        }
        
        /// <remarks/>
        public string City {
            get {
                return this.cityField;
            }
            set {
                this.cityField = value;
            }
        }
        
        /// <remarks/>
        public string AdministrativeArea {
            get {
                return this.administrativeAreaField;
            }
            set {
                this.administrativeAreaField = value;
            }
        }
        
        /// <remarks/>
        public string PostalCode {
            get {
                return this.postalCodeField;
            }
            set {
                this.postalCodeField = value;
            }
        }
        
        /// <remarks/>
        public string Country {
            get {
                return this.countryField;
            }
            set {
                this.countryField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ElectronicMailAddress")]
        public string[] ElectronicMailAddress {
            get {
                return this.electronicMailAddressField;
            }
            set {
                this.electronicMailAddressField = value;
            }
        }
    }
}
