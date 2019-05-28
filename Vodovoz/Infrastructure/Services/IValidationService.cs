﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using QSValidation;

namespace Vodovoz.Infrastructure.Services
{
	public interface IValidationService
	{
		IValidator GetValidator(IValidatableObject validatableObject, IDictionary<object, object> contextItems = null);
	}
}