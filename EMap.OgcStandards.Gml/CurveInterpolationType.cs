namespace EMap.OgcStandards.Gml {
    
    
    /// <remarks/>
    
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml")]
    public enum CurveInterpolationType {
        
        /// <remarks/>
        linear,
        
        /// <remarks/>
        geodesic,
        
        /// <remarks/>
        circularArc3Points,
        
        /// <remarks/>
        circularArc2PointWithBulge,
        
        /// <remarks/>
        circularArcCenterPointWithRadius,
        
        /// <remarks/>
        elliptical,
        
        /// <remarks/>
        clothoid,
        
        /// <remarks/>
        conic,
        
        /// <remarks/>
        polynomialSpline,
        
        /// <remarks/>
        cubicSpline,
        
        /// <remarks/>
        rationalSpline,
    }
}
