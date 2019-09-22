namespace EMap.OgcStandards.Ogc {
    
    
    /// <remarks/>
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/ogc")]
    [System.Xml.Serialization.XmlRootAttribute("And", Namespace="http://www.opengis.net/ogc", IsNullable=false)]
    public partial class BinaryLogicOpType : LogicOpsType {
        
        private object[] itemsField;
        
        private ItemsChoiceType1[] itemsElementNameField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("And", typeof(BinaryLogicOpType))]
        [System.Xml.Serialization.XmlElementAttribute("BBOX", typeof(BBOXType))]
        [System.Xml.Serialization.XmlElementAttribute("Beyond", typeof(DistanceBufferType))]
        [System.Xml.Serialization.XmlElementAttribute("Contains", typeof(BinarySpatialOpType))]
        [System.Xml.Serialization.XmlElementAttribute("Crosses", typeof(BinarySpatialOpType))]
        [System.Xml.Serialization.XmlElementAttribute("DWithin", typeof(DistanceBufferType))]
        [System.Xml.Serialization.XmlElementAttribute("Disjoint", typeof(BinarySpatialOpType))]
        [System.Xml.Serialization.XmlElementAttribute("Equals", typeof(BinarySpatialOpType))]
        [System.Xml.Serialization.XmlElementAttribute("Function", typeof(FunctionType))]
        [System.Xml.Serialization.XmlElementAttribute("Intersects", typeof(BinarySpatialOpType))]
        [System.Xml.Serialization.XmlElementAttribute("Not", typeof(UnaryLogicOpType))]
        [System.Xml.Serialization.XmlElementAttribute("Or", typeof(BinaryLogicOpType))]
        [System.Xml.Serialization.XmlElementAttribute("Overlaps", typeof(BinarySpatialOpType))]
        [System.Xml.Serialization.XmlElementAttribute("PropertyIsBetween", typeof(PropertyIsBetweenType))]
        [System.Xml.Serialization.XmlElementAttribute("PropertyIsEqualTo", typeof(BinaryComparisonOpType))]
        [System.Xml.Serialization.XmlElementAttribute("PropertyIsGreaterThan", typeof(BinaryComparisonOpType))]
        [System.Xml.Serialization.XmlElementAttribute("PropertyIsGreaterThanOrEqualTo", typeof(BinaryComparisonOpType))]
        [System.Xml.Serialization.XmlElementAttribute("PropertyIsLessThan", typeof(BinaryComparisonOpType))]
        [System.Xml.Serialization.XmlElementAttribute("PropertyIsLessThanOrEqualTo", typeof(BinaryComparisonOpType))]
        [System.Xml.Serialization.XmlElementAttribute("PropertyIsLike", typeof(PropertyIsLikeType))]
        [System.Xml.Serialization.XmlElementAttribute("PropertyIsNotEqualTo", typeof(BinaryComparisonOpType))]
        [System.Xml.Serialization.XmlElementAttribute("PropertyIsNull", typeof(PropertyIsNullType))]
        [System.Xml.Serialization.XmlElementAttribute("Touches", typeof(BinarySpatialOpType))]
        [System.Xml.Serialization.XmlElementAttribute("Within", typeof(BinarySpatialOpType))]
        [System.Xml.Serialization.XmlElementAttribute("comparisonOps", typeof(ComparisonOpsType))]
        [System.Xml.Serialization.XmlElementAttribute("logicOps", typeof(LogicOpsType))]
        [System.Xml.Serialization.XmlElementAttribute("spatialOps", typeof(SpatialOpsType))]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemsElementName")]
        public object[] Items {
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
        public ItemsChoiceType1[] ItemsElementName {
            get {
                return this.itemsElementNameField;
            }
            set {
                this.itemsElementNameField = value;
            }
        }
    }
}
