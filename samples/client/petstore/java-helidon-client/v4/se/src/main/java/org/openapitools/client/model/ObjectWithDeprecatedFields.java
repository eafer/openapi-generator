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

package org.openapitools.client.model;

import com.fasterxml.jackson.annotation.JsonInclude;
import com.fasterxml.jackson.annotation.JsonProperty;
import com.fasterxml.jackson.annotation.JsonCreator;
import com.fasterxml.jackson.annotation.JsonTypeName;
import com.fasterxml.jackson.annotation.JsonValue;
import java.math.BigDecimal;
import java.util.ArrayList;
import java.util.Arrays;
import java.util.List;
import org.openapitools.client.model.DeprecatedObject;




public class ObjectWithDeprecatedFields  {
  
  private String uuid;

  private BigDecimal id;

  private DeprecatedObject deprecatedRef;

  private List<String> bars = null;

 /**
   * Get uuid
   * @return uuid
  **/
  public String getUuid() {
    return uuid;
  }

  /**
    * Set uuid
  **/
  public void setUuid(String uuid) {
    this.uuid = uuid;
  }

  public ObjectWithDeprecatedFields uuid(String uuid) {
    this.uuid = uuid;
    return this;
  }

 /**
   * Get id
   * @return id
   * @deprecated
  **/
  @Deprecated
  public BigDecimal getId() {
    return id;
  }

  /**
    * Set id
  **/
  public void setId(BigDecimal id) {
    this.id = id;
  }

  public ObjectWithDeprecatedFields id(BigDecimal id) {
    this.id = id;
    return this;
  }

 /**
   * Get deprecatedRef
   * @return deprecatedRef
   * @deprecated
  **/
  @Deprecated
  public DeprecatedObject getDeprecatedRef() {
    return deprecatedRef;
  }

  /**
    * Set deprecatedRef
  **/
  public void setDeprecatedRef(DeprecatedObject deprecatedRef) {
    this.deprecatedRef = deprecatedRef;
  }

  public ObjectWithDeprecatedFields deprecatedRef(DeprecatedObject deprecatedRef) {
    this.deprecatedRef = deprecatedRef;
    return this;
  }

 /**
   * Get bars
   * @return bars
   * @deprecated
  **/
  @Deprecated
  public List<String> getBars() {
    return bars;
  }

  /**
    * Set bars
  **/
  public void setBars(List<String> bars) {
    this.bars = bars;
  }

  public ObjectWithDeprecatedFields bars(List<String> bars) {
    this.bars = bars;
    return this;
  }

  public ObjectWithDeprecatedFields addBarsItem(String barsItem) {
    this.bars.add(barsItem);
    return this;
  }


  /**
    * Create a string representation of this pojo.
  **/
  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class ObjectWithDeprecatedFields {\n");
    
    sb.append("    uuid: ").append(toIndentedString(uuid)).append("\n");
    sb.append("    id: ").append(toIndentedString(id)).append("\n");
    sb.append("    deprecatedRef: ").append(toIndentedString(deprecatedRef)).append("\n");
    sb.append("    bars: ").append(toIndentedString(bars)).append("\n");
    sb.append("}");
    return sb.toString();
  }

  /**
   * Convert the given object to string with each line indented by 4 spaces
   * (except the first line).
   */
  private static String toIndentedString(Object o) {
    if (o == null) {
      return "null";
    }
    return o.toString().replace("\n", "\n    ");
  }
}

