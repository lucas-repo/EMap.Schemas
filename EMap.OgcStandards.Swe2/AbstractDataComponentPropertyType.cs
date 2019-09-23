namespace EMap.OgcStandards.Swe2 {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/swe/2.0")]
    public partial class AbstractDataComponentPropertyType {
        
        private AbstractDataComponentType abstractDataComponentField;


        [System.Xml.Serialization.XmlElementAttribute("Quantity", typeof(QuantityType))]
        public AbstractDataComponentType AbstractDataComponent {
            get {
                return this.abstractDataComponentField;
            }
            set {
                this.abstractDataComponentField = value;
            }
        }
    }
}
