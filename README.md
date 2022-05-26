# dotnet-core-webapi-jwt
.net core webapi jwt인증 예제샘플

- Spring에서만 해본 jwt 인증을 core는 어찌 하는지 예제 샘플.
- Spring security 마냥 인증/권한부여 하는 것도 별도로 찾아봐야 할듯.

### 참조 사이트
https://aspdotnet.tistory.com/2831

### nuget
```
Microsoft.AspNetCore.Authentication.JwtBearer
Microsoft.IdentityModel.JsonWebTokens
System.IdentityModel.Tokens.Jwt
```

### 기타 doc
```
# Controller Action 에 사용할 특성
[FromBody] : 요청의 바디에 있는 Raw 데이터로 부터 객체를 생성한다.
[FromForm]: 요청의 바디에 있는 form-data로 부터 객체를 생성한다. 데이터는 키-값 쌍으로 제공된다.
[FromHeader] : 요청의 해더에 있는 데이터로 부터 객체를 생성한다. 데이터는 키-값 쌍으로 제공된다.
[FromQuery] : 요청의 쿼리 스트링으로 부터 객체를 생성한다. 데이터는 키-값 쌍으로 제공된다.
[FromRoute] : 요청의 라우팅 정보로 부터 객체를 생성한다. 데이터는 URL로 제공된다.
[FromServices] : HttpRequest 객체가 가진 데이터로부터 객체를 생성한다. 
```
