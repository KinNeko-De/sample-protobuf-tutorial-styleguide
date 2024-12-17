using S000.V1;
using System;
using System.Collections.Generic;
using System.Text;

namespace KinNekoDe.ApiContract.Sample;
internal class FileName
{
    public void Test()
    {
        var test = new S611.V1.OneOnf()
        {
        };
        test.Natural = new S611.V1.NaturalPerson()
        {
            FamilyName = "test",
            GivenName = "test",
        };
        test.Company = new S611.V1.LegalPerson()
        {
            Name = "test",
        };
    }
}
