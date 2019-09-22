namespace EMap.OgcStandards.Ogc {
    
    
    /// <remarks/>
    
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/ogc")]
    public enum ComparisonOperatorType {
        
        /// <remarks/>
        LessThan,
        
        /// <remarks/>
        GreaterThan,
        
        /// <remarks/>
        LessThanEqualTo,
        
        /// <remarks/>
        GreaterThanEqualTo,
        
        /// <remarks/>
        EqualTo,
        
        /// <remarks/>
        NotEqualTo,
        
        /// <remarks/>
        Like,
        
        /// <remarks/>
        Between,
        
        /// <remarks/>
        NullCheck,
    }
}
