using EMap.OgcStandards.Gml3_2;

namespace EMap.OgcStandards.Gmlcov1 {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gmlcov/1.0")]
    [System.Xml.Serialization.XmlRootAttribute("SimpleMultiPoint", Namespace="http://www.opengis.net/gmlcov/1.0", IsNullable=false)]
    public partial class SimpleMultiPointType : AbstractGeometricAggregateType {
        
        private DirectPositionListType positionsField;
        
        
        public DirectPositionListType positions {
            get {
                return this.positionsField;
            }
            set {
                this.positionsField = value;
            }
        }
    }
}
