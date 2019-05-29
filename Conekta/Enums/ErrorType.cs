using System;
using System.Collections.Generic;
using System.Text;

namespace Conekta.Enums
{
    public enum ErrorType
    {
        /// <summary>
        /// HTTP 500
        /// An unexpected error thrown by Conekta. And this error is catchable via ApiError class.
        /// </summary>
        api_error = 500,
        /// <summary>
        /// HTTP 401
        /// The api key provided in the request was invalid, or it did not have permissions to
        /// perform this request. And this error is catchable via AuthenticationError class.
        /// </summary>
        authentication_error = 401,
        /// <summary>
        /// HTTP 409
        /// A version conflict occured, most likely an invalid version was provided in your request headers.
        /// </summary>
        conflict_error = 409,
        /// <summary>
        /// HTTP 400
        /// The JSON body of your request was not a valid JSON object and could not be parsed or the
        /// request was improperly encoded. And this error is catchable via MalformedRequestError class
        /// </summary>
        malformed_request_error = 400,
        /// <summary>
        /// HTTP 422
        /// Some of the parameters in your request were missing or had invalid values, see the details
        /// section of your error for more information. And this error is catchable via ParameterValidationError class
        /// </summary>
        parameter_validation_error = 422,
        /// <summary>
        /// HTTP 412
        /// Some additional steps need to be performed before processing your request. If you are
        /// processing an order for example, the sum of the line_items must be greater
        /// than zero before it can be processed.
        /// </summary>
        precondition_required_error = 412,
        /// <summary>
        /// HTTP 402
        /// This is an expected error when processing credit cards, and will routinely occur when an
        /// operation cannot be performed (e.g. processing a credit card). And this error is
        /// catchable via ProcessingError class
        /// </summary>
        processing_error = 402,
        /// <summary>
        /// HTTP 404
        /// The object on which you wished to perform this operation could not be found,
        /// this often occurs when your are using keys with incorrect permissions or for the
        /// wrong account. And this error is catchable via ResourceNotFoundError class
        /// </summary>
        resource_not_found_error = 404
    }
}
