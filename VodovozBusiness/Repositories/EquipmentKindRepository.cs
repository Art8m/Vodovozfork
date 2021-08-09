﻿using System.Collections.Generic;
using System.Linq;
using QS.DomainModel.UoW;
using Vodovoz.Domain;

namespace Vodovoz.Repositories
{
	public static class EquipmentKindRepository
	{
		public static List<EquipmentKind> GetPaidRentEquipmentKinds (IUnitOfWork uow)
		{
			var availableTypes = uow.Session.CreateCriteria (typeof(PaidRentPackage))
				.List<PaidRentPackage> ()
				.Select (p => p.EquipmentKind)
				.Distinct ().ToList ();
			return availableTypes;
		}
	}
}
