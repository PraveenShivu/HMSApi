using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace HMS_Data_Layer.DBContext;

[Table("m_FacilityDepartment")]
public partial class MFacilityDepartment
{
    [Key]
    public int FacilityDepartmentId { get; set; }

    public int FacilityId { get; set; }

    public int DepartmentId { get; set; }

    [StringLength(20)]
    public string? CreatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreatedDateTime { get; set; }

    [StringLength(20)]
    public string? ModifiedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ModifiedDateTime { get; set; }

    public bool ActiveFlag { get; set; }

    [ForeignKey("DepartmentId")]
    [InverseProperty("MFacilityDepartments")]
    public virtual MDepartment Department { get; set; } = null!;

    [ForeignKey("FacilityId")]
    [InverseProperty("MFacilityDepartments")]
    public virtual MFacility Facility { get; set; } = null!;

    [InverseProperty("Department")]
    public virtual ICollection<MBillAutoCharge> MBillAutoCharges { get; set; } = new List<MBillAutoCharge>();

    [InverseProperty("FacilityDepartment")]
    public virtual ICollection<MFacilityDepartmentPatientType> MFacilityDepartmentPatientTypes { get; set; } = new List<MFacilityDepartmentPatientType>();

    [InverseProperty("FacilityDepartment")]
    public virtual ICollection<MFacilityDepartmentProvider> MFacilityDepartmentProviders { get; set; } = new List<MFacilityDepartmentProvider>();

    [InverseProperty("FacilityDepartment")]
    public virtual ICollection<MFacilityDepartmentServiceLocation> MFacilityDepartmentServiceLocations { get; set; } = new List<MFacilityDepartmentServiceLocation>();

    [InverseProperty("Department")]
    public virtual ICollection<TPatientAccountCharge> TPatientAccountCharges { get; set; } = new List<TPatientAccountCharge>();

    [InverseProperty("Department")]
    public virtual ICollection<TPatientAccountOrder> TPatientAccountOrders { get; set; } = new List<TPatientAccountOrder>();
}
