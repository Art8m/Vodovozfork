﻿using System;
using System.ComponentModel.DataAnnotations;
using QS.DomainModel.Entity;
using QS.HistoryLog;
using Vodovoz.Domain.Operations;
using Vodovoz.Domain.Service;

namespace Vodovoz.Domain.Documents
{
	[Appellative (Gender = GrammaticalGender.Feminine,
		NominativePlural = "строки талона разгрузки",
		Nominative = "строка талоны разгрузки")]
	[HistoryTrace]
	public class CarUnloadDocumentItem: PropertyChangedBase, IDomainObject
	{
		public virtual int Id { get; set; }

		CarUnloadDocument document;

		public virtual CarUnloadDocument Document {
			get { return document; }
			set { SetField (ref document, value, () => Document); }
		}

		ReciveTypes reciveType;

		public virtual ReciveTypes ReciveType { 
			get { return reciveType; } 
			set { SetField (ref reciveType, value, () => ReciveType); }
		}

		WarehouseMovementOperation movementOperation;

		public virtual WarehouseMovementOperation MovementOperation { 
			get { return movementOperation; }
			set { SetField (ref movementOperation, value, () => MovementOperation); }
		}
		
		EmployeeNomenclatureMovementOperation employeeNomenclatureMovementOperation;
		public virtual EmployeeNomenclatureMovementOperation EmployeeNomenclatureMovementOperation { 
			get => employeeNomenclatureMovementOperation;
			set => SetField (ref employeeNomenclatureMovementOperation, value);
		}

		ServiceClaim serviceClaim;

		[Display (Name = "Заявка на сервис")]
		public virtual ServiceClaim ServiceClaim {
			get { return serviceClaim; }
			set { SetField (ref serviceClaim, value, () => ServiceClaim); }
		}

		string redhead;
		[Display(Name = "№ кулера")]
		public virtual string Redhead {
			get { return redhead; }
			set { SetField(ref redhead, value, () => Redhead); }
		}

		CullingCategory typeOfDefect;
		[Display(Name = "Тип брака")]
		public virtual CullingCategory TypeOfDefect {
			get { return typeOfDefect; }
			set { SetField(ref typeOfDefect, value, () => TypeOfDefect); }
		}

		DefectSource defectSource;
		[Display(Name = "Источник брака")]
		public virtual DefectSource DefectSource {
			get { return defectSource; }
			set { SetField(ref defectSource, value, () => DefectSource); }
		}

		public virtual string Title =>
			String.Format("[{2}] {0} - {1}",
				MovementOperation.Nomenclature.Name,
				MovementOperation.Nomenclature.Unit.MakeAmountShortStr(MovementOperation.Amount),
				document.Title);
	}

	public enum ReciveTypes
	{
		[Display (Name = "Возврат тары")]
		Bottle,
		[Display (Name = "Оборудование по заявкам")]
		Equipment,
		[Display (Name = "Возврат недовоза")]
		Returnes,
		[Display(Name = "Брак")]
		Defective,
		[Display (Name = "Возврат кассового оборудования")]
		ReturnCashEquipment
	}

	public class ReciveTypesStringType : NHibernate.Type.EnumStringType
	{
		public ReciveTypesStringType () : base (typeof(ReciveTypes))
		{
		}
	}
}

