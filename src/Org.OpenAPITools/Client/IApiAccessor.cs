/*
 * API для аптечных сетей
 *
 * Авторизация по токену, используйте заголовок          Authorization: Bearer токен         пример:          Authorization: Bearer iJKLCJhbGciOiwIjoxN3MzM0zUw9zDuGk4-sYMmf9L_8WRU          Для того чтобы работать с API через интерфейс swagger (ниже, по кнопке Try it out),         нажмите кнопку Authorize и укажите токен в формате Bearer токен.         Пример: Bearer iJKLCJhbGciOiwIjoxN3MzM0zUw9zDuGk4-sYMmf9L_8WRU 
 *
 * The version of the OpenAPI document: v2
 * Contact: info@pharm-zakaz.ru
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using RestSharp;

namespace Org.OpenAPITools.Client
{
    /// <summary>
    /// Represents configuration aspects required to interact with the API endpoints.
    /// </summary>
    public interface IApiAccessor
    {
        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        Configuration Configuration {get; set;}

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        String GetBasePath();

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        ExceptionFactory ExceptionFactory { get; set; }
    }
}