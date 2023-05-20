var app = angular.module('my-app', []);
app.controller('bookSearchCtrl',function($scope,$http){
  
    $http.get("https://localhost:44373/api/book/all").then(function(resp){
        $scope.books = resp.data;
    },function(err){
        alert(err);
    });
});
