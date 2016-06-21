﻿using System;
using Vodovoz.Domain.Chat;
using FluentNHibernate.Mapping;

namespace Vodovoz.HMap
{
	public class LastReadedMessageMap : ClassMap<LastReadedMessage>
	{
		public LastReadedMessageMap ()
		{
			Table("chat_last_readed_message");

			Id(x => x.Id).Column ("id").GeneratedBy.Native();
			Map (x => x.LastDateTime).Column ("last_datetime");
			References (x => x.Chat).Column("chat_id");
			References (x => x.Employee).Column("employee_id");
		}
	}
}