/**
 *
 * Please note:
 * This class is auto generated by OpenAPI Generator (https://openapi-generator.tech).
 * Do not edit this file manually.
 *
 */

@file:Suppress(
    "ArrayInDataClass",
    "EnumEntryName",
    "RemoveRedundantQualifierName",
    "UnusedImport"
)

package org.openapitools.client.models


import com.fasterxml.jackson.annotation.JsonEnumDefaultValue
import com.fasterxml.jackson.annotation.JsonProperty

/**
 * 
 *
 * @param id Query
 * @param outcomes 
 */


data class Query (

    /* Query */
    @get:JsonProperty("id")
    val id: kotlin.Long? = null,

    @get:JsonProperty("outcomes")
    val outcomes: kotlin.collections.List<Query.Outcomes>? = null

) {

    /**
     * 
     *
     * Values: SUCCESS,FAILURE,SKIPPED,unknown_default_open_api
     */
    enum class Outcomes(val value: kotlin.String) {
        @JsonProperty(value = "SUCCESS") SUCCESS("SUCCESS"),
        @JsonProperty(value = "FAILURE") FAILURE("FAILURE"),
        @JsonProperty(value = "SKIPPED") SKIPPED("SKIPPED"),
        @JsonProperty(value = "unknown_default_open_api") @JsonEnumDefaultValue unknown_default_open_api("unknown_default_open_api");
    }

}

