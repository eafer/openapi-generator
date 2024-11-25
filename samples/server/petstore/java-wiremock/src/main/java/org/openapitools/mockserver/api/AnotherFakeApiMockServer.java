/**
* NOTE: This class is auto generated by OpenAPI Generator (https://openapi-generator.tech) (7.11.0-SNAPSHOT).
* https://openapi-generator.tech
* Do not edit the class manually.
*/
package org.openapitools.mockserver.api;

import static com.github.tomakehurst.wiremock.client.WireMock.*;
import com.github.tomakehurst.wiremock.client.MappingBuilder;
import com.github.tomakehurst.wiremock.http.Fault;

public class AnotherFakeApiMockServer {

    public static MappingBuilder stubCall123testSpecialTags200(@javax.annotation.Nonnull String body, String response) {
        MappingBuilder stub = patch(urlPathEqualTo("/another-fake/dummy"))
            .withHeader("Accept", havingExactly("application/json"))
            .withRequestBody(equalToJson(body))
            .willReturn(aResponse()
                .withStatus(200)
                .withHeader("Content-Type", "application/json")
                .withBody(response)
            );


        return stub;
    }

    public static MappingBuilder stubCall123testSpecialTagsFault(@javax.annotation.Nonnull String body, Fault fault) {
        MappingBuilder stub = patch(urlPathEqualTo("/another-fake/dummy"))
            .withHeader("Accept", havingExactly("application/json"))
            .withRequestBody(equalToJson(body))
            .willReturn(aResponse()
                .withFault(fault)
            );


        return stub;
    }

    public static String call123testSpecialTags200ResponseSample1() {
        return "{ \"client\" : \"client\" }";
    }

    public static String call123testSpecialTagsRequestSample1() {
        return "{ \"client\" : \"client\" }";
    }


}
