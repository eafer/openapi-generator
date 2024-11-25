/**
 * OpenAPI Petstore
 * This spec is mainly for testing Petstore server and contains fake endpoints, models. Please do not use this for any other purpose. Special characters: \" \\
 *
 * The version of the OpenAPI document: 1.0.0
 * 
 *
 * NOTE: This class is auto generated by OpenAPI-Generator 7.11.0-SNAPSHOT.
 * https://openapi-generator.tech
 * Do not edit the class manually.
 */



#include "User.h"

#include <string>
#include <vector>
#include <map>
#include <sstream>
#include <stdexcept>
#include <regex>
#include <boost/lexical_cast.hpp>
#include <boost/property_tree/ptree.hpp>
#include <boost/property_tree/json_parser.hpp>
#include "helpers.h"

using boost::property_tree::ptree;
using boost::property_tree::read_json;
using boost::property_tree::write_json;

namespace org {
namespace openapitools {
namespace server {
namespace model {

User::User(boost::property_tree::ptree const& pt)
{
        fromPropertyTree(pt);
}


std::string User::toJsonString(bool prettyJson /* = false */) const
{
	std::stringstream ss;
	write_json(ss, this->toPropertyTree(), prettyJson);
    // workaround inspired by: https://stackoverflow.com/a/56395440
    std::regex reg("\\\"([0-9]+\\.{0,1}[0-9]*)\\\"");
    std::string result = std::regex_replace(ss.str(), reg, "$1");
    return result;
}

void User::fromJsonString(std::string const& jsonString)
{
	std::stringstream ss(jsonString);
	ptree pt;
	read_json(ss,pt);
	this->fromPropertyTree(pt);
}

ptree User::toPropertyTree() const
{
	ptree pt;
	ptree tmp_node;
	pt.put("id", m_Id);
	pt.put("username", m_Username);
	pt.put("firstName", m_FirstName);
	pt.put("lastName", m_LastName);
	pt.put("email", m_Email);
	pt.put("password", m_Password);
	pt.put("phone", m_Phone);
	pt.put("userStatus", m_UserStatus);
	return pt;
}

void User::fromPropertyTree(ptree const &pt)
{
	ptree tmp_node;
	m_Id = pt.get("id", 0L);
	m_Username = pt.get("username", "");
	m_FirstName = pt.get("firstName", "");
	m_LastName = pt.get("lastName", "");
	m_Email = pt.get("email", "");
	m_Password = pt.get("password", "");
	m_Phone = pt.get("phone", "");
	m_UserStatus = pt.get("userStatus", 0);
}

int64_t User::getId() const
{
    return m_Id;
}

void User::setId(int64_t value)
{
    m_Id = value;
}


std::string User::getUsername() const
{
    return m_Username;
}

void User::setUsername(std::string value)
{
    m_Username = value;
}


std::string User::getFirstName() const
{
    return m_FirstName;
}

void User::setFirstName(std::string value)
{
    m_FirstName = value;
}


std::string User::getLastName() const
{
    return m_LastName;
}

void User::setLastName(std::string value)
{
    m_LastName = value;
}


std::string User::getEmail() const
{
    return m_Email;
}

void User::setEmail(std::string value)
{
    m_Email = value;
}


std::string User::getPassword() const
{
    return m_Password;
}

void User::setPassword(std::string value)
{
    m_Password = value;
}


std::string User::getPhone() const
{
    return m_Phone;
}

void User::setPhone(std::string value)
{
    m_Phone = value;
}


int32_t User::getUserStatus() const
{
    return m_UserStatus;
}

void User::setUserStatus(int32_t value)
{
    m_UserStatus = value;
}



std::vector<User> createUserVectorFromJsonString(const std::string& json)
{
    std::stringstream sstream(json);
    boost::property_tree::ptree pt;
    boost::property_tree::json_parser::read_json(sstream,pt);

    auto vec = std::vector<User>();
    for (const auto& child: pt) {
        vec.emplace_back(User(child.second));
    }

    return vec;
}

}
}
}
}

