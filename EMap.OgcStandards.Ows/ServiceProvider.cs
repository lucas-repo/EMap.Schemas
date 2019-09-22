namespace EMap.OgcStandards.Ows {
    
    
    /// <remarks/>
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opengis.net/ows")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.opengis.net/ows", IsNullable=false)]
    public partial class ServiceProvider {
        
        private string providerNameField;
        
        private OnlineResourceType1 providerSiteField;
        
        private ResponsiblePartySubsetType serviceContactField;
        
        /// <remarks/>
        public string ProviderName {
            get {
                return this.providerNameField;
            }
            set {
                this.providerNameField = value;
            }
        }
        
        /// <remarks/>
        public OnlineResourceType1 ProviderSite {
            get {
                return this.providerSiteField;
            }
            set {
                this.providerSiteField = value;
            }
        }
        
        /// <remarks/>
        public ResponsiblePartySubsetType ServiceContact {
            get {
                return this.serviceContactField;
            }
            set {
                this.serviceContactField = value;
            }
        }
    }
}
