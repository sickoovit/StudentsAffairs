namespace SessionStorage.Repositories;

public interface ISessionRepository
{
	Task InitSessionAsync(ISessionStorageService sessionStorageService, Guid userId);
	Task<Session> GetSessionAsync(ISessionStorageService sessionStorageService);
	Guid GetSessionId(ISessionStorageService sessionStorageService);
	Guid GetSessionUserId(ISessionStorageService sessionStorageService);
}
