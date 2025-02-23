import { Module } from '@nestjs/common';
import { AuthService } from './services/authService';
import { AuthGuard } from './auth.guard';
import { JwtStrategy } from './jwt.strategy';

@Module({
  providers: [AuthService, AuthGuard, JwtStrategy],
  exports: [AuthService],
})
export class AuthModel {}