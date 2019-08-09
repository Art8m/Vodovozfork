﻿using System;
using QS.Project.Journal;
using Vodovoz.Domain.Client;

namespace Vodovoz.JournalNodes
{
	public class DebtorJournalNode : JournalEntityNodeBase<CallTask>
	{
		public int AddressId { get; set; }

		public string AddressName { get; set; }

		public int ClientId { get; set; }

		public string ClientName { get; set; }

		public PersonType OPF { get; set; }

		public int DebtByAddress { get; set; }

		public int DebtByClient { get; set; }

		public int Reserve { get; set; }

		public string RowColor { get; set; } = "black";

		public DateTime? LastOrderDate { get; set; }

		public int? LastOrderBottles { get; set; }

		public string IsResidueExist { get; set; } = "нет";
	}
}
