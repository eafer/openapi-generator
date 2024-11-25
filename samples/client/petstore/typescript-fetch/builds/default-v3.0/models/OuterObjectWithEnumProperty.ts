/* tslint:disable */
/* eslint-disable */
/**
 * OpenAPI Petstore
 * This spec is mainly for testing Petstore server and contains fake endpoints, models. Please do not use this for any other purpose. Special characters: \" \\
 *
 * The version of the OpenAPI document: 1.0.0
 * 
 *
 * NOTE: This class is auto generated by OpenAPI Generator (https://openapi-generator.tech).
 * https://openapi-generator.tech
 * Do not edit the class manually.
 */

import { mapValues } from '../runtime';
import type { OuterEnumInteger } from './OuterEnumInteger';
import {
    OuterEnumIntegerFromJSON,
    OuterEnumIntegerFromJSONTyped,
    OuterEnumIntegerToJSON,
    OuterEnumIntegerToJSONTyped,
} from './OuterEnumInteger';

/**
 * 
 * @export
 * @interface OuterObjectWithEnumProperty
 */
export interface OuterObjectWithEnumProperty {
    /**
     * 
     * @type {OuterEnumInteger}
     * @memberof OuterObjectWithEnumProperty
     */
    value: OuterEnumInteger;
}



/**
 * Check if a given object implements the OuterObjectWithEnumProperty interface.
 */
export function instanceOfOuterObjectWithEnumProperty(value: object): value is OuterObjectWithEnumProperty {
    if (!('value' in value) || value['value'] === undefined) return false;
    return true;
}

export function OuterObjectWithEnumPropertyFromJSON(json: any): OuterObjectWithEnumProperty {
    return OuterObjectWithEnumPropertyFromJSONTyped(json, false);
}

export function OuterObjectWithEnumPropertyFromJSONTyped(json: any, ignoreDiscriminator: boolean): OuterObjectWithEnumProperty {
    if (json == null) {
        return json;
    }
    return {
        
        'value': OuterEnumIntegerFromJSON(json['value']),
    };
}

export function OuterObjectWithEnumPropertyToJSON(json: any): OuterObjectWithEnumProperty {
    return OuterObjectWithEnumPropertyToJSONTyped(json, false);
}

export function OuterObjectWithEnumPropertyToJSONTyped(value?: OuterObjectWithEnumProperty | null, ignoreDiscriminator: boolean = false): any {
    if (value == null) {
        return value;
    }

    return {
        
        'value': OuterEnumIntegerToJSON(value['value']),
    };
}

