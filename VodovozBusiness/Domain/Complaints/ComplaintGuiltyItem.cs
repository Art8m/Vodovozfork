﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Gamma.Utilities;
using QS.DomainModel.Entity;
using QS.HistoryLog;
using Vodovoz.Domain.Employees;

namespace Vodovoz.Domain.Complaints
{
	[Appellative(Gender = GrammaticalGender.Masculine,
		NominativePlural = "виновные в жалобе",
		Nominative = "виновный в жалобе",
		Prepositional = "виновном в жалобе",
		PrepositionalPlural = "виновных в жалобе")]
	[HistoryTrace]
	public class ComplaintGuiltyItem : PropertyChangedBase, IDomainObject, IValidatableObject
	{
		public virtual int Id { get; set; }

		private Complaint complaint;
		[Display(Name = "Жалоба")]
		public virtual Complaint Complaint {
			get => complaint;
			set => SetField(ref complaint, value, () => Complaint);
		}

		private ComplaintGuiltyTypes? guiltyType;
		[Display(Name = "Виновник")]
		public virtual ComplaintGuiltyTypes? GuiltyType {
			get => guiltyType;
			set => SetField(ref guiltyType, value, () => GuiltyType);
		}

		private Employee employee;
		[Display(Name = "Сотрудник")]
		public virtual Employee Employee {
			get => employee;
			set => SetField(ref employee, value, () => Employee);
		}

		private Subdivision subdivision;
		[Display(Name = "Подразделение")]
		public virtual Subdivision Subdivision {
			get => subdivision;
			set => SetField(ref subdivision, value, () => Subdivision);
		}

		public virtual string Title => string.Format("Виновный №{0} в жалобе №{1}", Id, Complaint?.Id);

		public ComplaintGuiltyItem() { }

		public virtual string GetGuiltySubdivisionOrEmployee => Subdivision?.Name ?? Employee?.ShortName;

		#region IValidatableObject implementation

		public virtual IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
		{
			if(GuiltyType == null)
				yield return new ValidationResult(
					"Виновная сторона не выбрана",
					new[] { this.GetPropertyName(o => o.GuiltyType) }
				);
			if(GuiltyType == ComplaintGuiltyTypes.Employee && Employee == null)
				yield return new ValidationResult(
					"Укажите виновного сотрудника",
					new[] { this.GetPropertyName(o => o.Employee) }
				);
			if(GuiltyType == ComplaintGuiltyTypes.Subdivision && Subdivision == null)
				yield return new ValidationResult(
					"Укажите виновный отдел ВВ",
					new[] { this.GetPropertyName(o => o.Subdivision) }
				);
		}

		#endregion
	}
}