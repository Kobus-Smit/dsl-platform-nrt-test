module my_app {

root user(id) {
  guid id { sequence; }
  string name { unique; }
  int? nullable_int;
  string? nullable_string;
  List<string>? nullable_string_list;
}

root rating(id) {
  guid id { sequence; }
  string? comment;
  guid? user_id;
  relationship user_rel(user_id) user;
  user *capturer { serialization name 'capturer'; }
  user? *reviewer { serialization name 'reviewer'; }
}

snowflake<rating> rating_list {
  id;
  comment;
  user_rel.name as user_name;
  capturer.name capturer_name;
  capturer.nullable_string capturer_nullable_string;
  reviewer.name reviewer_name;
  reviewer.nullable_string reviewer_nullable_string;
}

}