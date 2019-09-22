namespace EMap.OgcStandards.Se {
    
    
    /// <remarks/>
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/se")]
    [System.Xml.Serialization.XmlRootAttribute("ChannelSelection", Namespace="http://www.opengis.net/se", IsNullable=false)]
    public partial class ChannelSelectionType {
        
        private SelectedChannelType[] itemsField;
        
        private ItemsChoiceType15[] itemsElementNameField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("BlueChannel", typeof(SelectedChannelType))]
        [System.Xml.Serialization.XmlElementAttribute("GrayChannel", typeof(SelectedChannelType))]
        [System.Xml.Serialization.XmlElementAttribute("GreenChannel", typeof(SelectedChannelType))]
        [System.Xml.Serialization.XmlElementAttribute("RedChannel", typeof(SelectedChannelType))]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemsElementName")]
        public SelectedChannelType[] Items {
            get {
                return this.itemsField;
            }
            set {
                this.itemsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ItemsElementName")]
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ItemsChoiceType15[] ItemsElementName {
            get {
                return this.itemsElementNameField;
            }
            set {
                this.itemsElementNameField = value;
            }
        }
    }
}
