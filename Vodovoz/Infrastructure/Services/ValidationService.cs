﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using QSValidation;

namespace Vodovoz.Infrastructure.Services
{
	public class ValidationService : IValidationService
	{
		private readonly IValidationViewFactory validationViewFactory;

		public ValidationService(IValidationViewFactory validationViewFactory)
		{
			this.validationViewFactory = validationViewFactory;
		}

		public IValidator GetValidator(IValidatableObject validatableObject, IDictionary<object, object> contextItems = null)
		{
			return new ObjectValidator(validationViewFactory, validatableObject, contextItems);
		}
	}
}
