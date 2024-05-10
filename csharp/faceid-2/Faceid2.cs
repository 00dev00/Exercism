using System;
using System.Collections.Generic;

public class FacialFeatures
{
    public string EyeColor { get; }
    public decimal PhiltrumWidth { get; }

    public FacialFeatures(string eyeColor, decimal philtrumWidth)
    {
        EyeColor = eyeColor;
        PhiltrumWidth = philtrumWidth;
    }

    public override bool Equals(object obj) => obj is FacialFeatures ff && ff.EyeColor == EyeColor && ff.PhiltrumWidth == PhiltrumWidth;
    public override int GetHashCode() => HashCode.Combine(EyeColor, PhiltrumWidth);
}

public class Identity
{
    public static Identity Admin => new("admin@exerc.ism", new FacialFeatures("green", 0.9m));
    public string Email { get; }
    public FacialFeatures FacialFeatures { get; }

    public Identity(string email, FacialFeatures facialFeatures)
    {
        Email = email;
        FacialFeatures = facialFeatures;
    }
    
    public override bool Equals(object obj) => obj is Identity idn && idn.Email == Email && idn.FacialFeatures.Equals(FacialFeatures);
    public override int GetHashCode() => HashCode.Combine(Email, FacialFeatures);
}

public class Authenticator
{
    public HashSet<Identity> RegisteredIdentities = [];
    public static bool AreSameFace(FacialFeatures faceA, FacialFeatures faceB) => faceA.Equals(faceB);
    public bool IsAdmin(Identity identity) => identity.Equals(Identity.Admin);
    public bool Register(Identity identity) => RegisteredIdentities.Add(identity);
    public bool IsRegistered(Identity identity) => RegisteredIdentities.Contains(identity);
    public static bool AreSameObject(Identity identityA, Identity identityB) => ReferenceEquals(identityA, identityB);
}
