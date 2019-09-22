using EMap.OgcStandards.Ogc;

namespace EMap.OgcStandards.Se {
    
    
    /// <remarks/>
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/se")]
    [System.Xml.Serialization.XmlRootAttribute("MapItem", Namespace="http://www.opengis.net/se", IsNullable=false)]
    public partial class MapItemType : ExpressionType {
        
        private double dataField;
        
        private ParameterValueType valueField;
        
        /// <remarks/>
        public double Data {
            get {
                return this.dataField;
            }
            set {
                this.dataField = value;
            }
        }
        
        /// <remarks/>
        public ParameterValueType Value {
            get {
                return this.valueField;
            }
            set {
                this.valueField = value;
            }
        }
    }
}
